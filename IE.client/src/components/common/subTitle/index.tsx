import { Component } from "../../../domain/component";
import { Typography } from 'antd';
import Children from "../children";

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
            {props.component.childrens && <Children components={props.component.childrens} />}
        </div>
    )
}

export default SubTitle;