import { useDispatch } from "react-redux";
import { useAuth } from "../../hooks/useAuth";
import { AppDispatch } from "../../store";
import { useEffect } from "react";
import { setUserState } from "../../slices/userSlice";

interface Props {
    children: React.ReactNode;
}

const AuthProvider = ({ children }: Props) => {
    const { user } = useAuth();
    const dispatch = useDispatch<AppDispatch>();
    useEffect(() => {
        dispatch(setUserState({
            user: user,
            loading: !user
        }))
    }, [user, dispatch])
    return (
        <div>{children}</div>
    );
}

export default AuthProvider;