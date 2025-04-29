import { createSlice } from '@reduxjs/toolkit';
import { homeInitialState } from '../constants/homeState';
import { slices } from '../utils/constants';

const menuSlice = createSlice({
  name: slices.menu,
  initialState: homeInitialState,
  reducers: {
    setMenu(state, action) {
      state.menyKey = action.payload.menyKey;
    },
  }
});

export const { setMenu } = menuSlice.actions;
export default menuSlice.reducer;