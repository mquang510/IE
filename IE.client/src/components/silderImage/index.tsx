import { Carousel } from 'antd';
import { Component } from '../../domain/component';
interface SliderImageProps {
  component: Component;
}
const SliderImage = (props: SliderImageProps) => {
  return (<Carousel style={props.component.style} effect="fade" autoplay arrows dots={false}>
    {props.component.data.map((x: any) => {
      return (
        <div>
          <img style={x.style} src={x.src}/>
        </div>
      )
    })}
  </Carousel>)
};

export default SliderImage;