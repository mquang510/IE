import { appActions } from "../utils/enums";
import { User } from "./user";

export interface AppState {
    menyKey: string;
    userInfo?: User;
    loading: boolean
}

export type AppAction = { 
    type: appActions.setUserInfo,
    payload: AppState 
};