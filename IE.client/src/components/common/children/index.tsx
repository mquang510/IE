import { Component } from "../../../domain/component";
import Content from "../content";

interface ChildrenProps {
    components: Component[];
}

const Children = (props: ChildrenProps) => {
    return (
        <div>
            {props.components.map((x: Component) => {
                return <Content component={x}/>
            })}
        </div>
    )
}

export default Children;