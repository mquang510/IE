import api from './api';
import { User } from '../domain/user';

export async function getUsers(): Promise<User> {
    const res = await api.post(`/users/api/getall`);
    return res.data;
}


export async function login(user: User): Promise<string> {
    const res = await api.post(`/users/api/login`, JSON.stringify(user), {
        headers: {
          "Content-Type": "application/json"
        }
    });
    return res.data.token;
}


export async function me(token: string): Promise<User> {
    const res = await api.get(`/users/api/me`, {
        headers: {
          "Content-Type": "application/json",
          "Authorization": 'Bearer ' + token
        }
    });
    return res.data;
}