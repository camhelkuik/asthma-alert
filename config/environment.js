'use strict';

module.exports = function(environment) {
  let ENV = {
    modulePrefix: 'asthma-alert',
    environment,
    rootURL: '/',
    locationType: 'auto',

    firebase: {
      apiKey: "AIzaSyB5r5IbqbvmzHodmYOL_6459BosylWT0oo",
      authDomain: "asthma-alert-43b43.firebaseapp.com",
      databaseURL: "https://asthma-alert-43b43.firebaseio.com",
      projectId: "asthma-alert-43b43",
      storageBucket: "",
      messagingSenderId: "201070301405",
      appId: "1:201070301405:web:65c15bfd4b3b6cb3"
    },

    // if using ember-cli-content-security-policy
    // contentSecurityPolicy: {
    //  'script-src': "'self' 'unsafe-eval' apis.google.com",
    //  'frame-src': "'self' https://*.firebaseapp.com",
    //  'connect-src': "'self' wss://*.firebaseio.com https://*.googleapis.com"
    // },

    EmberENV: {
      FEATURES: {
        // Here you can enable experimental features on an ember canary build
        // e.g. 'with-controller': true
      },
      EXTEND_PROTOTYPES: {
        // Prevent Ember Data from overriding Date.parse.
        Date: false
      }
    },

    APP: {
      // Here you can pass flags/options to your application instance
      // when it is created
    },

    apiNamespace: 'api',
    apiUrl: null,
  };

  if (environment === 'development') {
    // ENV.APP.LOG_RESOLVER = true;
    // ENV.APP.LOG_ACTIVE_GENERATION = true;
    // ENV.APP.LOG_TRANSITIONS = true;
    // ENV.APP.LOG_TRANSITIONS_INTERNAL = true;
    // ENV.APP.LOG_VIEW_LOOKUPS = true;
  }

  if (environment === 'test') {
    // Testem prefers this...
    ENV.locationType = 'none';

    // keep test console output quieter
    ENV.APP.LOG_ACTIVE_GENERATION = false;
    ENV.APP.LOG_VIEW_LOOKUPS = false;

    ENV.APP.rootElement = '#ember-testing';
    ENV.APP.autoboot = false;
  }

  if (environment === 'production') {
    // here you can enable a production-specific feature
  }

  return ENV;
};
