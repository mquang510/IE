import React from 'react';
import { BrowserRouter } from 'react-router-dom';
import AppRoutes from './router/index';
import './styles/global.scss';

export default function App() {
    return (
    <div className="App introduce-everything">
      <BrowserRouter>
        <AppRoutes />
      </BrowserRouter>
    </div>)
}
  