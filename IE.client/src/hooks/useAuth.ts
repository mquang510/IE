import { useEffect, useState } from "react";
import { User } from "../domain/user";
import { fetchUserInfo, fetchUserLogin } from "../usecases/fetchUserLogin";

export function useAuth() {
    const [user, setUser] = useState<User | undefined>(undefined);
  
    useEffect(() => {
      let token = localStorage.getItem("token");
      if (!token) {
        fetchUserLogin({
            email: '123@gmail.com',
            password: '123'
        }).then(response => {
            token = response
            localStorage.setItem("token", token);
            if (token) {
                fetchUserInfo(token)
                  .then(response => {
                    setUser(response);
                  })
                  .catch(() => {
                    setUser(undefined);
                  });
              }
        })
      }
      if (token) {
        fetchUserInfo(token)
          .then(response => {
            setUser(response);
          })
          .catch(() => {
            setUser(undefined);
          });
      }
      
    }, []);
  
    return { user };
}