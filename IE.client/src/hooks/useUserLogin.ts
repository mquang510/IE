import { useEffect, useState } from 'react';
import { fetchUserLogin } from '../usecases/fetchUserLogin';
import { User } from '../domain/user';

export function useUserLogin(user: User) {
  const [token, setToken] = useState<string | null>(null);

  useEffect(() => {
    fetchUserLogin(user).then(setToken);
  }, [user]);

  return token;
}