import { Routes, Route } from 'react-router-dom';
import HomePage from '../pages/home';
import AboutPage from '../pages/about';
import ProductPage from '../pages/product';

const AppRoutes = () => (
  <Routes>
    <Route path="/" element={<HomePage />} />
    <Route path="/about" element={<AboutPage />} />
    <Route path="/page" element={<ProductPage />} />
  </Routes>
);

export default AppRoutes;