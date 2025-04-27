import { User } from '../domain/user';
import {  login, me } from '../services/userService';

export async function fetchUserLogin(user: User): Promise<string> {
  const token = await login(user);
  return token;
}

export async function fetchUserInfo(token: string): Promise<User> {
    const user = await me(token);
    return user;
}