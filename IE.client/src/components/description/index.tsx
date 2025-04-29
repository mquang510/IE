import { Typography } from "antd"
import { Component } from "../../domain/component";
interface DescriptionProps {
    component: Component;
}
const Description = (props: DescriptionProps) => {
    return (
        <div>
            <Typography.Text style={props.component.style}>
                {props.component.content}
            </Typography.Text>
        </div>
    )
}

export default Description;