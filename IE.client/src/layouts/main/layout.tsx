import React, { useEffect } from 'react';
import Header from '../../components/header';
import Footer from '../../components/footer';
import styles from './style.module.scss';
import { useAuth } from '../../hooks/useAuth';
import { AppDispatch } from '../../store';
import { useDispatch } from 'react-redux';
import { setUserState } from '../../slices/userSlice';
import { Content } from 'antd/es/layout/layout';

interface Props {
    children: React.ReactNode;
}

export default function Layout ({ children }: Props) {
    const { user } = useAuth();
    const dispatch = useDispatch<AppDispatch>();
    useEffect(() => {
        dispatch(setUserState({
            userInfo: user,
            loading: !!user
        }))
    }, [user])
    return (
        <div className={styles.layout}>
          <Header />
          <Content className={styles.content}>{children}</Content>
          <Footer />
        </div>
    );
}