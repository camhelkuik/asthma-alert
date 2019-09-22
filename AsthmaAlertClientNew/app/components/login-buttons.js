import Component from '@ember/component';
import { inject as service } from '@ember/service';

export default Component.extend({
    session: service(),
    tagName: 'a',
    classNames: ['login-buttons'],

    actions: {
        invalidateSession() {
            this.get('session').invalidate();
        }
    }
});
