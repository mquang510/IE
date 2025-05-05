import { Component } from "../../../domain/component";
import Children from "../children";

interface WrapperProps {
    component: Component;
}

const Wrapper = (props: WrapperProps) => {
    return (
        <div>
            {props.component.content}
            {props.component.childrens && <Children components={props.component.childrens} />}
        </div>
    )
}

export default Wrapper;