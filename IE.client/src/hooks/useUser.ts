import { useEffect, useState } from 'react';
import { getUsers } from '../services/userService';
import { User } from '../domain/user';

export function useUser() {
  const [user, setUser] = useState<User | null>(null);

  useEffect(() => {
    getUsers().then(setUser);
  }, []);

  return user;
}