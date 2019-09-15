import OAuth2PasswordGrant from 'ember-simple-auth/authenticators/oauth2-password-grant';
import ENV from 'asthma-alert-client-new/config/environment';

export default OAuth2PasswordGrant.extend({
    serverTokenEndpoint: `${ENV.APP.host}/${ENV.APP.tokenPath}`
});