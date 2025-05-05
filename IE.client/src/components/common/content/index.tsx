import { Component } from "../../../domain/component";
import { ComponentTypes } from "../../../utils/enums";
import SliderImage from "../silderImage";
import Title from "../title";
import SubTitle from "../subTitle";
import Description from "../description";
import Wrapper from "../wrapper";

interface ContentProps {
    component: Component
}

const Content = (props: ContentProps) => {
    const renderComponent = (component: Component) => {
        switch(component.type){
            case ComponentTypes.SliderImage:
                return <SliderImage component={component}/>
            case ComponentTypes.Title:
                return <Title component={component} />
            case ComponentTypes.SubTitle:
                return <SubTitle component={component}/>
            case ComponentTypes.Description:
                return <Description component={component}/>
            case ComponentTypes.Wrapper:
                return <Wrapper component={component}/>
        }
    }
    return (
        <div>
           {renderComponent(props.component)}
        </div>
    )
}

export default Content;