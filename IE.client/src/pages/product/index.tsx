import { useDispatch } from "react-redux";
import SliderImage from "../../components/silderImage";
import { productInitialState } from "../../constants/productState";
import MainLayout from "../../layouts/main/layout"
import { AppDispatch } from "../../store";
import styles from './style.module.scss';
import { setMenu } from "../../slices/menuSlice";
import { useEffect } from "react";
import { mockComponents } from "../../domain/component";
import { ComponentTypes } from "../../utils/enums";
import Title from "../../components/title";
import SubTitle from "../../components/subTitle";
import Description from "../../components/description";

export default function ProductPage () {
    const dispatch = useDispatch<AppDispatch>();
    useEffect(() => {
        dispatch(setMenu(productInitialState))
    }, [])
    const data = mockComponents
    return (
        // <AppProvider initialState={productInitialState}>
            <MainLayout>
                <div className={styles.content}>
                    {data.map(x => {
                        switch(x.type){
                            case ComponentTypes.SliderImage:
                                return <SliderImage component={x}/>
                            case ComponentTypes.Title:
                                return <Title component={x} />
                            case ComponentTypes.SubTitle:
                                return <SubTitle component={x}/>
                            case ComponentTypes.Description:
                                return <Description component={x}/>
                        }

                    })}
                </div>
            </MainLayout>
        // </AppProvider>
    )
}