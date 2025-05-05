import { Carousel } from 'antd';
import { Component } from '../../../domain/component';
import { Image } from '../../../domain/image';
import Children from '../children';
interface SliderImageProps {
  component: Component;
}
const SliderImage = (props: SliderImageProps) => {
  return (<Carousel style={props.component.style} effect="fade" autoplay arrows dots={false}>
    {props.component.data?.map((x: Image) => {
      return (
        <div>
          <img style={x.style} src={x.src}/>
        </div>
      )
    })}
    {props.component.childrens && <Children components={props.component.childrens} />}
  </Carousel>)
};

export default SliderImage;