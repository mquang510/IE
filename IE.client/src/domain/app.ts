import { appActions } from "../utils/enums";

export interface AppState {
    menyKey: string;
}

export type AppAction = { 
    type: appActions,
    payload: AppState 
};