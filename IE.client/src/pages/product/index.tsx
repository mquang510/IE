import { productInitialState } from "../../constants/productState";
import AppProvider from "../../contexts/appContext";
import MainLayout from "../../layouts/main/layout"
import styles from './style.module.scss';

export default function ProductPage () {
   
    return (
        <AppProvider initialState={productInitialState}>
            <MainLayout>
                <div className={styles.content}>
                <p>Page content.</p>
                </div>
            </MainLayout>
        </AppProvider>
    )
}