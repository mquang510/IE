import { Component } from "../../domain/component";
import { Typography } from 'antd';

const { Text } = Typography;
interface SubTitleProps {
    component: Component;
}
const SubTitle = (props: SubTitleProps) => {
    return (
        <div>
            <Text italic style={props.component.style}>
                {props.component.content}
            </Text>
        </div>
    )
}

export default SubTitle;