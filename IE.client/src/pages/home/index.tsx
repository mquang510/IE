import { useDispatch } from "react-redux";
import { homeInitialState } from "../../constants/homeState";
import MainLayout from "../../layouts/main/layout"
import { AppDispatch } from "../../store";
import styles from './style.module.scss';
import { useEffect } from "react";
import { setMenu } from "../../slices/menuSlice";

export default function HomePage () {
    const dispatch = useDispatch<AppDispatch>();
    useEffect(() => {
        dispatch(setMenu(homeInitialState))
    }, [])
    return (
        // <AppProvider initialState={menu}>
            <MainLayout>
                <div className={styles.content}>
                <h1>Welcome to MyApp!</h1>
                <p>This is the homepage content.</p>
                </div>
            </MainLayout>
        // </AppProvider>
    )
}