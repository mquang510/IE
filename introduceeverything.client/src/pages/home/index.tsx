import { homeInitialState } from "../../constants/homeState";
import AppProvider from "../../contexts/appContext";
import MainLayout from "../../layouts/main/layout"
import styles from './style.module.scss';

export default function HomePage () {
    return (
        <AppProvider initialState={homeInitialState}>
            <MainLayout>
                <div className={styles.content}>
                <h1>Welcome to MyApp!</h1>
                <p>This is the homepage content.</p>
                </div>
            </MainLayout>
        </AppProvider>
    )
}