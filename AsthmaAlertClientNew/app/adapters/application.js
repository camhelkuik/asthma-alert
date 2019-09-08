import DS from 'ember-data';
import ENV from 'asthma-alert-client-new/config/environment';

export default DS.JSONAPIAdapter.extend({
    namespace: ENV.APP.namespace,
    host: ENV.APP.host
});