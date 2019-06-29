import OAuth2PasswordGrant from 'ember-simple-auth/authenticators/oauth2-password-grant';

export default OAuth2PasswordGrant.extend({
    //need to change this, but not sure what to change it tooooo.....
    serverTokenEndpoint: 'https://localhost:2000/users/login'
});