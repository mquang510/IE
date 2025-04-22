import React from 'react';
import { Layout } from 'antd';
import styles from './style.module.scss';

const { Footer } = Layout;

const AppFooter = () => (
  <Footer className={styles.footer}>©2025 MyApp. All rights reserved.</Footer>
);

export default AppFooter;