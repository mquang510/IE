import { Typography } from "antd"
import { Component } from "../../../domain/component";
import Children from "../children";

interface TitleProps {
    component: Component;
}

const Title = (props: TitleProps) => {
    return (
        <div>
            <Typography.Title level={1} style={props.component.style}>
                {props.component.content}
            </Typography.Title>
            {props.component.childrens && <Children components={props.component.childrens} />}
        </div>
    )
}

export default Title;