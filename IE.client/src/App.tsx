import { BrowserRouter } from 'react-router-dom';
import AppRoutes from './router/index';
import './styles/global.scss';
import { Provider } from 'react-redux';
import store from './store';

export default function App() {
    return (
    <div className="App introduce-everything">
      <BrowserRouter>
        <Provider store={store}>
          <AppRoutes />
        </Provider>
      </BrowserRouter>
    </div>)
}
  