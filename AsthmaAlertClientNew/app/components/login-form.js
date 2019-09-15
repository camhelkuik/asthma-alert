import Component from '@ember/component';
import { inject as service } from '@ember/service';

export default Component.extend({
    session: service(),
    notify: service(),

    actions: {
      authenticate() {
        let { identification, password } = this.getProperties('identification', 'password');
        this.get('session').authenticate('authenticator:oauth2', identification, password).catch(() => {
            this.get('notify').error('Authentication failed.');
        });
      }
    }
});
