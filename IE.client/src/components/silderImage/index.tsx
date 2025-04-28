import React from 'react';
import { Carousel } from 'antd';
import styles from './style.module.scss';

const SliderImage = () => {
    return (<Carousel effect="fade" autoplay arrows dots={false}>
      <div>
        <h3 className={styles['slider-image-style']}>1</h3>
      </div>
      <div>
        <h3 className={styles['slider-image-style']}>2</h3>
      </div>
      <div>
        <h3 className={styles['slider-image-style']}>3</h3>
      </div>
      <div>
        <h3 className={styles['slider-image-style']}>4</h3>
      </div>
    </Carousel>)
};

export default SliderImage;