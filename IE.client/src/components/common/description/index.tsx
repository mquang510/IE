import { Typography } from "antd"
import { Component } from "../../../domain/component";
import Children from "../children";
interface DescriptionProps {
    component: Component;
}
const Description = (props: DescriptionProps) => {
    return (
        <div>
            <Typography.Text style={props.component.style}>
                {props.component.content}
            </Typography.Text>
            {props.component.childrens && <Children components={props.component.childrens} />}
        </div>
    )
}

export default Description;