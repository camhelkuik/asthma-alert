import { helper } from '@ember/component/helper';

export function pollenValue([params]/*, hash*/) {
  switch (params){
    case 1:
      return "Very Low";
    case 2:
      return "Low";
    case 3:
      return "Moderate";
    case 4:
      return "High";
    case 5:
      return "Very High";
    default:
      return "No Pollen";    
  }
}

export default helper(pollenValue);
