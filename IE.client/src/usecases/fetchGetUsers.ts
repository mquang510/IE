import { getUsers } from '../services/userService';
import { User } from '../domain/user';

export async function fetchUserProfile(): Promise<User> {
  const users = await getUsers();
  return users;
}