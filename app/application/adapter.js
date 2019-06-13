import DS from 'ember-data';
import DataAdapterMixin from 'ember-simple-auth/mixins/data-adapter-mixin';
import config from 'asthma-alert/config/environment';

export default DS.JSONAPIAdapter.extend(DataAdapterMixin, {
    host: config.apiUrl,
    namespace: config.apiNamespace,
    authorizer: 'authorizer:application'
});
