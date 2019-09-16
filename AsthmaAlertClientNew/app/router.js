import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType,
  rootURL: config.rootURL
});

Router.map(function() {
  this.route('login');
  this.route('s', function(){
    this.route('tracking-items');
  });
  this.route('daily-aq');
});

export default Router;
