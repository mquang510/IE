import { useEffect, useState } from 'react';
import { Product } from '../domain/product';
import { getProducts } from '../services/productService';

export function useProduct() {
  const [product, setProduct] = useState<Product | null>(null);

  useEffect(() => {
    getProducts().then(setProduct);
  }, []);

  return product;
}