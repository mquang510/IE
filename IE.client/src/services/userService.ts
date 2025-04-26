import api from './api';
import { User } from '../domain/user';

export async function getUsers(): Promise<User> {
    const res = await api.get(`/users/api/getall`);
    return res.data;
}