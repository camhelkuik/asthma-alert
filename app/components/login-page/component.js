import Component from '@ember/component';
import { inject } from '@ember/service';

export default Component.extend({
    authManager: inject('session'),

    actions: {
        authenticate(){
            const { login, password } = this.getProperties('login', 'password');
            this.get('authManager').authenticate('authenticator:oauth2', login, password).then(() => {
                alert('Success! Click one of the top links!');
            }), (err) => {
                alert('Error obtaining token: ' + err.responseText);
            }
        }
    }
});
