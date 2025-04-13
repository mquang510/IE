import { createContext, ReactNode, useReducer } from "react";
import { AppAction, AppState } from "../domain/app";
import { appReducer } from "../reducers/appReducer";

export const AppContext = createContext<{
  state: AppState;
  dispatch: React.Dispatch<AppAction>;
}>({
  state: { menyKey: '' },
  dispatch: () => null,
});


export default function AppProvider ({
  children,
  initialState,
}: {
  children: ReactNode;
  initialState: AppState;
}) {
  const [state, dispatch] = useReducer(appReducer, initialState);
  return (
      <AppContext.Provider value={{state, dispatch}}>
        {children}
      </AppContext.Provider>
    )
  }