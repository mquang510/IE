import { Typography } from "antd"
import { Component } from "../../domain/component";

interface TitleProps {
    component: Component;
}

const Title = (props: TitleProps) => {
    return (
        <div>
            <Typography.Title level={1} style={props.component.style}>
                {props.component.content}
            </Typography.Title>
        </div>
    )
}



export default Title;