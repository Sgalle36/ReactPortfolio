import PropTypes from 'prop-types';
import './Section.css'

function Section({ children, title, desc, tag }) {
    return (
        <section id={tag}>
            <div>
                <h2>{ title }</h2>
                <h4>{ desc }</h4>
            </div>
            <div>
                { children }
            </div>
        </section>
  );
}

Section.propTypes = {
    children: PropTypes.children,
    title: PropTypes.string.isRequired,
    desc: PropTypes.string,
    tag: PropTypes.string.isRequired,

}

export default Section;