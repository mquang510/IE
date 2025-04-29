import { useDispatch } from "react-redux";
import { aboutInitialState } from "../../constants/aboutState";
import MainLayout from "../../layouts/main/layout"
import styles from './style.module.scss';
import { AppDispatch } from "../../store";
import { useEffect } from "react";
import { setMenu } from "../../slices/menuSlice";

export default function AboutPage () {
    const dispatch = useDispatch<AppDispatch>();
    useEffect(() => {
        dispatch(setMenu(aboutInitialState))
    }, [])
    return (
        // <AppProvider initialState={aboutInitialState}>
            <MainLayout>
                <div className={styles.content}>
                <h1>About me </h1>
                </div>
            </MainLayout>
        // </AppProvider>
    )
}