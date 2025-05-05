import { useEffect, useState } from "react";
import { User } from "../domain/user";
import { fetchUserInfo, fetchUserLogin } from "../usecases/fetchUserLogin";

export function useAuth() {
    const [user, setUser] = useState<User | undefined>(undefined);
  
    useEffect(() => {
      const token = localStorage.getItem("token");
      // if (!token) {
      //   fetchUserLogin({
      //       email: '123@gmail.com',
      //       password: '123'
      //   }).then(response => {
      //       token = response
      //       localStorage.setItem("token", token);
      //       if (token) {
      //           fetchUserInfo(token)
      //             .then(response => {
      //               setUser(response);
      //             })
      //             .catch(() => {
      //               localStorage.removeItem("token")
      //               setUser(undefined);
      //             });
      //         }
      //   })
      // }
      if (token) {
        fetchUserInfo(token)
          .then(response => {
            setUser(response);
          })
          .catch(() => {
            localStorage.removeItem("token")
            setUser(undefined);
          });
      }
      
    }, []);
  
    return { user };
}