import { AppState, AppAction } from '../domain/app';
import { appActions } from '../utils/enums';

export const appReducer = (state: AppState, action: AppAction): AppState => {
  switch (action.type) {
    case appActions.setUserInfo:
      return { ...state, ...action.payload };
    default:
      return state;
  }
};