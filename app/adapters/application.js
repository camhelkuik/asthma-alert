import FirebaseAdapter from 'emberfire/adapters/firebase';
import DataAdapterMixin from 'ember-simple-auth/mixins/data-adapter-mixin';

export default FirebaseAdapter.extend(DataAdapterMixin, {
    // namespace: 'api/v1',
    // host: 'http://localhost:2000',
    authorizer: 'authorizer:oauth2',
    // authorize(xhr) {
    //     let { access_token } = this.get('session.data.authenticated');
    //     if (isPresent(access_token)) {
    //       xhr.setRequestHeader('Authorization', `Bearer ${access_token}`);
    //     }
    // }
});
