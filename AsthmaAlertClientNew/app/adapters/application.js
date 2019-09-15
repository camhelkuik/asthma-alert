import DS from 'ember-data';
import ENV from 'asthma-alert-client-new/config/environment';
import { inject as service } from '@ember/service';
import { computed }  from '@ember/object';

export default DS.JSONAPIAdapter.extend({
    session: service(),

    namespace: ENV.APP.namespace,
    host: ENV.APP.host,
    headers: computed('session.data.authenticated.token', function() {
        let token = this.get('session.data.authenticated.access_token');
        return { Authorization: `Bearer ${token}`};
    })
});