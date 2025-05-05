import { BrowserRouter } from 'react-router-dom';
import AppRoutes from './router/index';
import './styles/global.scss';
import { Provider } from 'react-redux';
import store from './store';
import AutuProvider from './layouts/authProvider';

export default function App() {
  return (
  <div className="App introduce-everything">
    <BrowserRouter>
      <Provider store={store}>
        <AutuProvider>
          <AppRoutes />
        </AutuProvider>
      </Provider>
    </BrowserRouter>
  </div>)
}
  