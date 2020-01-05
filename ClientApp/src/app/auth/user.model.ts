export interface User {
    id: number;
    name: string;
    username: string;
    password: string;
    isAdmin: boolean;
    isInactive: boolean;
    lastChangeDateTime: string;
    lastChangeUserId: number;
}
