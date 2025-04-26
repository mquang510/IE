import axios from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:7283',
  timeout: 10000,
});

export default api;