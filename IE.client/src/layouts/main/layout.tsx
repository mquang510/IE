import React from 'react';
import Header from '../../components/header';
import Footer from '../../components/footer';
import styles from './style.module.scss';
import { Content } from 'antd/es/layout/layout';

interface Props {
    children: React.ReactNode;
}

const Layout = ({ children }: Props) => {
    return (
        <div className={styles.layout}>
          <Header />
          <Content className={styles.content}>{children}</Content>
          <Footer />
        </div>
    );
}

export default Layout;