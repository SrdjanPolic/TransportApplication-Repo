// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.

export const environment = {
  production: false,
  urlAddress: 'https://localhost:5001',
  firebaseConfig: {
    apiKey: 'AIzaSyCG5n_rzmmfbrATrB9ec_KX8i4S3UYeG5Q',
    authDomain: 'atomicsped-15940.firebaseapp.com',
    databaseURL: 'https://atomicsped-15940.firebaseio.com',
    projectId: 'atomicsped-15940',
    storageBucket: 'atomicsped-15940.appspot.com',
    messagingSenderId: '162117081462'
  }
};
