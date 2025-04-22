import React from 'react';
import Header from '../../components/header';
import Footer from '../../components/footer';
import styles from './style.module.scss';

interface Props {
    children: React.ReactNode;
}

export default function Layout ({ children }: Props){
    return (
        <div className={styles.layout}>
          <Header />
          <main className={styles.content}>{children}</main>
          <Footer />
        </div>
    );
}