import { aboutInitialState } from "../../constants/aboutState";
import AppProvider from "../../contexts/appContext";
import MainLayout from "../../layouts/main/layout"
import styles from './style.module.scss';

export default function AboutPage () {
    return (
        <AppProvider initialState={aboutInitialState}>
            <MainLayout>
                <div className={styles.content}>
                <h1>About me </h1>
                </div>
            </MainLayout>
        </AppProvider>
    )
}