export interface UserForCreation {
  name: string;
  username: string;
  password: string;
  isAdmin: boolean;
  isInactive: boolean;
  lastChangeDateTime: Date;
  lastChangeUserId: number;
}
