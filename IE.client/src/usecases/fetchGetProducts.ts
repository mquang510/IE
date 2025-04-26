import { Product } from '../domain/product';
import { getProducts } from '../services/productService';

export async function fetchProducts(): Promise<Product> {
  const products = await getProducts();
  return products;
}