import { useDispatch } from "react-redux";
import { productInitialState } from "../../constants/productState";
import MainLayout from "../../layouts/main/layout"
import { AppDispatch } from "../../store";
import styles from './style.module.scss';
import { setMenu } from "../../slices/menuSlice";
import { useEffect } from "react";
import { mockComponents } from "../../domain/component";
import Content from "../../components/common/content";

export default function ProductPage () {
    const dispatch = useDispatch<AppDispatch>();
    useEffect(() => {
        dispatch(setMenu(productInitialState))
    }, [dispatch])
    const data = mockComponents
    return (
        // <AppProvider initialState={productInitialState}>
            <MainLayout>
                <div className={styles.content}>
                    {data.map(x => {
                        return <Content component={x}/>
                    })}
                </div>
            </MainLayout>
        // </AppProvider>
    )
}