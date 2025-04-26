import api from './api';
import { Product } from '../domain/product';

export async function getProducts(): Promise<Product> {
    const res = await api.get(`/products/api/getall`);
    return res.data;
}