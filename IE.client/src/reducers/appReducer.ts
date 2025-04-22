import { AppState, AppAction } from '../domain/app';

export const appReducer = (state: AppState, action: AppAction): AppState => {
  switch (action.type) {
    case '':
      return { ...state, menyKey: action.payload };
    default:
      return state;
  }
};