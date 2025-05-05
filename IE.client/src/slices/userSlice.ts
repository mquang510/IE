import { createSlice } from '@reduxjs/toolkit';
import { UserInitState } from '../domain/user';
import { slices } from '../utils/constants';

const initialState: UserInitState = {
  user: {
    id: '',
    name: '',
    email: '',
    password: ''
  },
  loading: true
};

const userSlice = createSlice({
  name: slices.user,
  initialState: initialState,
  reducers: {
    setUserState(state, action) {
      state.user = action.payload.user;
      state.loading = action.payload.loading;
    },
    setUser(state, action) {
      state.user = action.payload;
    },
    setLoading(state, action) {
      state.loading = action.payload;
    }
  }
});

export const { setUser, setLoading, setUserState } = userSlice.actions;
export default userSlice.reducer;